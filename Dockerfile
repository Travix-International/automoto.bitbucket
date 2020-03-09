FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1

MAINTAINER Travix

RUN mkdir -p /dotnetapp

WORKDIR /dotnetapp

COPY . /dotnetapp

ENTRYPOINT ["/dotnetapp/automoto.bitbucket"]