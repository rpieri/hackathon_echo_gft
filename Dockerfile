FROM mcr.microsoft.com/dotnet/sdk:6.0-buster-slim AS restore
WORKDIR /app

COPY ./src ./src
WORKDIR /app/src/Echo.GFT.API
RUN dotnet restore Echo.GFT.API.csproj

FROM restore AS publish
WORKDIR /app/src/Echo.GFT.API
RUN dotnet publish Echo.GFT.API.csproj -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:6.0-buster-slim AS runtime
WORKDIR /app
EXPOSE 5001
COPY --from=publish /out .
ENTRYPOINT ["dotnet", "Echo.GFT.API.dll"]