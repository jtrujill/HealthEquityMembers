FROM mcr.microsoft.com/mssql/server:2017-latest

ARG sa_password

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=$sa_password

USER root

WORKDIR /app

COPY ["entrypoint.sh", "import-data.sh", "setup.sql", "./"]

RUN chmod +x import-data.sh

#USER mssql

ENTRYPOINT [ "/bin/bash", "entrypoint.sh" ]