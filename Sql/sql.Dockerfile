FROM mcr.microsoft.com/mssql/server 

ARG PROJECT_DIR=/tmp/devdatabase
RUN mkdir -p $PROJECT_DIR
WORKDIR $PROJECT_DIR
COPY Sql/InitializeDatabase.sql ./
COPY Sql/wait-for-it.sh ./
COPY Sql/entrypoint.sh ./
COPY Sql/setup.sh ./

CMD ["/bin/bash", "entrypoint.sh"]