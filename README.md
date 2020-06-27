# Mgranja.api1 - ASP.NET Core 3.0 Server

Retorna a taxa de juros (a.m.) atual da aplicação

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
```
