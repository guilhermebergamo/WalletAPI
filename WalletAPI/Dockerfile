# 🔧 Stage de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# 🧠 Copiar os arquivos .csproj e restaurar dependências
COPY ["src/01-API/Wallet.Api/Wallet.Api.csproj", "src/01-API/Wallet.Api/"]
COPY ["src/02-Application/Wallet.Application/Wallet.Application.csproj", "src/02-Application/Wallet.Application/"]
COPY ["src/03-Domain/Wallet.Domain/Wallet.Domain.csproj", "src/03-Domain/Wallet.Domain/"]
COPY ["src/04-Infrastructure/Wallet.Infrastructure/Wallet.Infrastructure.csproj", "src/04-Infrastructure/Wallet.Infrastructure/"]
COPY ["src/05-SharedKernel/Wallet.SharedKernel.csproj", "src/05-SharedKernel/"]

RUN dotnet restore "src/01-API/Wallet.Api/Wallet.Api.csproj"

# 🚀 Copiar tudo e compilar
COPY . .
WORKDIR "/app/src/01-API/Wallet.Api"
RUN dotnet publish "Wallet.Api.csproj" -c Release -o /app/publish

# 🏗 Stage de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# 🔥 Expor a porta da aplicação
EXPOSE 80

# 🎯 Rodar a aplicação
ENTRYPOINT ["dotnet", "Wallet.Api.dll"]