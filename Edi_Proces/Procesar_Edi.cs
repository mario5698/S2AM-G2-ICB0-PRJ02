using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_Dades;

namespace Edi_Proces
{
    class Procesar_Edi
    {
        Acceso con = new Acceso();
        EdiEntities db;
        string ord_id = "", id_op_a = "", id_fac = "", id_ag = "";
        string order = "", ord_date = "", order_id_type = "";
        string id_pla = "", id_ref = "", quant = "", fecha_ent = "";


        public void Split()
        {
            db = new EdiEntities();
            string line;
            int counter = 0;

            System.IO.StreamReader file =
            new System.IO.StreamReader("..\\ejecutables\\DadesClients.edi");
            while ((line = file.ReadLine()) != null)
            {
                counter++;
            }

            string[] array = new string[counter];

            int arrayCounter = 0;

            file = new System.IO.StreamReader("..\\ejecutables\\DadesClients.edi");
            while ((line = file.ReadLine()) != null)
            {
                array[arrayCounter] = line;
                arrayCounter++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                string[] linea = array[i].Split('|');
                if (linea[0] == "ORD")
                {
                    order = linea[1];
                    order_id_type = (Select(linea[2], "idPriority", "codePriority", "Priority"));
                }
                else if (linea[0] == "DTM")
                {
                    ord_date = linea[1];
                }
                else if (linea[0] == "NADMS")
                {
                    id_ag = (Select(linea[1], "idOperationalArea", "codeOperationalArea", "OperationalAreas"));
                    id_op_a = (Select(linea[2], "idAgency", "codeAgency", "Agencies"));
                }
                else if (linea[0] == "NADMR")
                {
                    id_fac = Select(linea[1], "idFactory", "codeFactory", "Factories");
                    Insert_O();
                    Insert_OI();
                }
                else if (linea[0] == "LIN")
                {
                    id_pla = Select(linea[1], "idPlanet", "codeplanet", "Planets");
                    id_ref = Select(linea[2], "idReference", "codeReference", "References");
                }
                else if (linea[0] == "QTYLIN")
                {
                    quant = linea[2];
                }
                else if (linea[0] == "DTMLIN")
                {
                    fecha_ent = linea[1];
                    Insert_OD();
                }
            }
        }

        private void Insert_O()
        {

            DateTime fecha_ord = DateTime.ParseExact(ord_date, "yyyyMMdd", null);
            Order o = new Order
            {
                codeOrder = order,
                dateOrder = fecha_ord,
                IdPriority = short.Parse(order_id_type),
                IdFactory = short.Parse(id_fac)
            };
            db.Orders.Add(o);
            db.SaveChanges();
            ord_id = (Select(order, "idOrder", "codeOrder", "Orders"));
        }

        private void Insert_OD()
        {
            DateTime fecha_entrega = DateTime.ParseExact(fecha_ent, "yyyyMMdd", null);
            OrdersDetail od = new OrdersDetail
            {
                idOrder = short.Parse(ord_id),
                idPlanet = short.Parse(id_pla),
                idReference = short.Parse(id_ref),
                Quantity = short.Parse(quant),
                DeliveryDate = fecha_entrega,
            };
            db.OrdersDetails.Add(od);
            db.SaveChanges();
        }

        private void Insert_OI()
        {
            OrderInfo oi = new OrderInfo
            {
                idOrder = short.Parse(ord_id),
                idAgency = short.Parse(id_ag),
                idOperationalArea = short.Parse(id_op_a)
            };
            db.OrderInfoes.Add(oi);
            db.SaveChanges();
        }


        private string Select(string have, string want, string give, string table)
        {
            string consulta = "select " + want + " from [dbo].[" + table + "] where " + give + " = '" + have + "'";
            return con.PortarPerConsulta(consulta).Tables[0].Rows[0][0].ToString();
        }
    }
}

