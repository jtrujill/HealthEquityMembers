FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["HealthEquityMembers.csproj", "./"]
RUN dotnet restore "./HealthEquityMembers.csproj"
COPY . .
RUN dotnet build "HealthEquityMembers.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "HealthEquityMembers.csproj" -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /app
EXPOSE 5000/tcp
EXPOSE 5001/tcp

FROM base AS final
WORKDIR /app
COPY --from=publish /app .

COPY wait-for-it.sh ./
RUN chmod +x wait-for-it.sh

ENV ASPNETCORE_URLS "http://*:5000;https://*:5001"
CMD ["dotnet", "HealthEquityMembers.dll"]