# Orquestrador_Docker

Front-end: 
Aplicativo front-end para gerenciar recursos do Docker, como imagens e containers.
Este projeto foi gerado com Windows forms 

Funcionalidades:
O sistema tem as seguintes funcionalidades:
•	Listagem de todos os containers presentes na máquina host;
•	Exclusão de todos os containers na máquina host;
•	Exclusão de um container específico da máquina host; 
•	Criação de um novo container da máquina host;
•	Pull de uma nova imagem do repositório;
•	Exclusão de uma imagem que está na máquina host;
•	Exclusão de todas as imagens que estão na máquina host;
•	Listagem de todas as imagens que estão na máquina host.

Back-end : 

A API foi feita com a linguagem .NET.

Nesta parte foi criada uma instância de Linux na AWS, nela foi instalado o Docker (este que pode ser instalado no link a seguir: https://docs.docker.com/engine/install/ubuntu/), a partir do Docker instalado, a API pública do Docker que a AWS gera foi liberada.
Fluxo

O fluxo desse processo funciona da seguinte forma:

Front-end (Windows forms) requisita a API criada e está requisita a máquina de LINUX que está na AWS.
Execução
Para a execução do projeto é necessário rodar primeiro o projeto de API (API_DOCKER) e depois do front (FRONT_APP_DOCKER)

https://youtu.be/F_gjjPf4U7M

Integrantes
Bruna Cristina Torres 081180005
Laura Alves Ferreira 082180040
Mariana Carnevale de Lima 081180037
Vittoria Cassoni 081180039
