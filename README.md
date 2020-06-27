# mgranja-sample-api - ASP.NET Core 3.0 Server

Código de teste demonstrando a criação de duas APIs em .NET core

## Descrição

API1: 
- retorna uma taxa de juros fixa de 1%
- Caminho relativo /taxaJuros
- Exemplo: /taxaJuros (Retorno esperado 0,01)

API2/Endpoint1
- Endpoint1
- Calcula juros compostos usando um valor inicial e número de meses passados como parâmetro, e a taxa de juros fixa da API1
- Caminho relativo /calculaJuros
- Recebe dois parametros, valorinicial, e meses 
-Exemplo:/calculaJuros?valorinicial=100&meses=5 (Retorno esperado: 105,10)

API2/Endpoint2
- Retorna a URL do codigo fonte da aplicação (esta página)
- caminho relativo /showmethecode
- Exemplo: /taxaJuros (Retorno esperado https://github.com/moronigranja/mgranja-sample-api)

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/Mgranja.api1
docker build -t mgranja.api1 .
docker run -p 5000:5000 mgranja.api1
cd src/Mgranja.api2
docker build -t mgranja.api2
docker run -p 5002:5002 mgranja.api2
```
