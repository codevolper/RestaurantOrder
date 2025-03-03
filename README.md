# Restaurant Order API
This repository contains a simple API that send one message for a RabbitMQ queue, with a restaurant orders. 

# Prerequisites

- .NET 8 SDK
- RabbitMQ Server
- Docker
- WSL
- Visual Studio or any preferred IDE

# Scope
Many producers can send messages that go to one queue, and many consumers can try to receive data from one queue.
For this scenario the application contains both concepts, producer and consumer.
The application will send and receive restaurant order messages and redirect them to a specific queue to be processed.

# Features

- Produce an order with menu items 
- Consume an order in specific kitchen area

# Instalation

* Clone the repository
```
    git clone https://github.com/codevolper/RestaurantOrder
```

* Restore dependencies
```
    dotnet restore
```

* Build Docker image
```
    docker build -t your-image-name .
```

* Run docker image
```
    docker run -d --name your-container-name -p 8080:8080 -p 8081:8081 your-image-name
```

* Build Rabbit
```
    docker-compose up --build
```

* Run rabbit image
```
    docker run -d --hostname restaurant-order --name rabbit-server -e RABBITMQ_DEFAULT_USER=guest -e RABBITMQ_DEFAULT_PASS=guest -p 5672:5672 -p 15672:15672 rabbitmq:3-management
```

# API Endpoints
* Request Body:
```
    {
      "description": "Combo Order",
      "items": [
        "Big Mac",
        "Coke",
        "Fresh Fries",
        "Sundae"
      ]
    }    
```

# Project Structure
* WebApi: Contains API controllers and configurations
* Domain: Contains domain entities such as Producer and Consumer
* Infrastructure: Contains the rabbit configuration and connection to the server

# Dependencies
* ASP.NET Core 8.0
* System.Data
* Rabbit MQ
* Docker
* WSL
