# Wait for SQL Server to be started and then run the sql script
./wait-for-it.sh localhost:1433 --timeout=300 --strict -- sleep 5s && \
/opt/mssql-tools18/bin/sqlcmd -S localhost -i InitializeDatabase.sql -C -U sa -P "$SA_PASSWORD"
