# 🛒 Microservices E-Commerce Backend (.NET + Docker)

A production-style backend system built using **Microservices Architecture** with ASP.NET Core. This project demonstrates scalable service design, API communication, authentication, and containerization using Docker.

---

## 📌 Table of Contents
- [Overview](#overview)
- [Architecture](#architecture)
- [Services](#services)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [API Flow](#api-flow)
- [Future Improvements](#future-improvements)
- [Learning Outcomes](#learning-outcomes)

---

## 📖 Overview

This project is designed to simulate a real-world **E-commerce backend system** using microservices.

Each service:
- Is independently deployable
- Has its own database
- Communicates via REST APIs
- Is containerized using Docker

---

## 🧱 Architecture

```
    Client (Postman / Frontend)
              |
              v
       +----------------+
       |  API Gateway   |
       +----------------+
        /      |       \
       v       v        v
+---------+ +---------+ +---------+
|  Auth   | | Product | |  Order  |
| Service | | Service | | Service |
+---------+ +---------+ +---------+
     |           |           |
     v           v           v
 Auth DB     Product DB   Order DB
```

---

## 🧩 Services

### 🔐 Auth Service
- User Registration & Login
- JWT Token Generation
- Role-Based Access Control (RBAC)

### 📦 Product Service
- Product CRUD operations
- Pagination & Filtering
- Inventory Management

### 🧾 Order Service
- Order Creation & Management
- Handles purchase workflow
- Maintains order history

### 🌐 API Gateway
- Central entry point
- Routes requests to services
- Validates authentication tokens

---

## 🛠️ Tech Stack

```
| Category        | Technology |
|----------------|-----------|
| Backend        | ASP.NET Core Web API |
| Language       | C# |
| Database       | SQL Server |
| Authentication | JWT |
| Container      | Docker, Docker Compose |
| Tools          | Git, Postman |
```
---

## 📁 Project Structure

```
microservices-ecommerce/
│
├── api-gateway/
├── auth-service/
├── product-service/
├── order-service/
├── docker-compose.yml
└── README.md
```

---

## ⚙️ Getting Started

### ✅ Prerequisites

- .NET 6 or higher
- Docker & Docker Compose
- Git

---

### 🚀 Run the Project

1. Clone the repository

```
git clone https://github.com/your-username/microservices-ecommerce.git

cd microservices-ecommerce
```
  
2. Run all services using Docker

```
docker-compose up --build
```

3. Access APIs via Postman or browser

---

## 🔄 API Flow

1. User logs in via **Auth Service**
2. Auth Service returns a **JWT Token**
3. Client sends token in request headers
4. API Gateway validates token
5. Request is routed to appropriate service
6. Service processes request and returns response

---

## 🔗 Service Communication

- Uses **synchronous REST APIs**
- Order Service communicates with Product Service for validation
- API Gateway handles all external traffic

---

## 🔮 Future Improvements

- Add Redis caching (performance optimization)
- Implement message broker (RabbitMQ / Kafka)
- Add centralized logging (ELK Stack)
- Add rate limiting (API Gateway)
- Add CI/CD pipeline
- Deploy on Kubernetes

---

## 🎯 Learning Outcomes

- Microservices architecture design
- API Gateway pattern
- Secure authentication using JWT
- Containerization with Docker
- Service-to-service communication
- Backend scalability principles

---

## 📜 License

This project is for learning and demonstration purposes.
