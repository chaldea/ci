FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY . .
WORKDIR /src/src/Chaldea.Ci.Hello.Web
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT dotnet Chaldea.Ci.Hello.Web.dll