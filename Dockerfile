#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Matchtickets1.csproj", "."]
RUN dotnet restore "./Matchtickets1.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Matchtickets1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Matchtickets1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Matchtickets1.dll"]