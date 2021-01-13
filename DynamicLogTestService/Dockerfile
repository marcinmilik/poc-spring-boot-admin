FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY DynamicLogTestService.csproj DynamicLogTestService/
RUN dotnet restore DynamicLogTestService/DynamicLogTestService.csproj
WORKDIR /src/DynamicLogTestService
COPY . .
RUN dotnet build DynamicLogTestService.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DynamicLogTestService.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DynamicLogTestService.dll"]