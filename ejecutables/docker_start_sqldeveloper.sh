 docker run -d --name srv-oracle -p 1521:1521 -p 8080:8080 -e ORACLE_ALLOW_REMOTE=true -e ORACLE_DISABLE_ASYNCH=true  -v /home/mario/Desktop/Volums/oracle/DB:/u01/app/oracle wnameless/oracle-xe-11g-r2

