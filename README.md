# 🛒 Microservices E-Commerce Backend (.NET + Docker)

A production-style backend system built using microservices architecture with .NET Core. This project demonstrates scalable service design, API communication, containerization, and backend best practices.

---

## 🚀 Features

- Microservices-based architecture
- RESTful APIs using ASP.NET Core
- JWT Authentication & Role-Based Access Control
- Service-to-service communication
- Centralized API Gateway
- Dockerized services
- Database per service pattern
- Basic observability (logging)

---

## 🧱 Architecture Overview

The system is split into multiple independent services:

- **API Gateway**
- **Auth Service**
- **Product Service**
- **Order Service**

Each service:
- Runs independently
- Has its own database
- Communicates via HTTP APIs

---

## 🧩 Services

### 🔐 Auth Service
- User registration & login
- JWT token generation
- Role-based access control

### 📦 Product Service
- Product CRUD operations
- Pagination & filtering
- Inventory tracking

### 🧾 Order Service
- Create & manage orders
- Handles product purchase logic
- Maintains order history

### 🌐 API Gateway
- Single entry point for all clients
- Routes requests to appropriate services
- Handles authentication validation

---

## 🗺️ Architecture Diagram

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

 
---

## 🛠️ Tech Stack

- **Backend:** ASP.NET Core Web API
- **Language:** C#
- **Database:** SQL Server
- **Containerization:** Docker
- **Authentication:** JWT
- **Tools:** Postman, Git

---

## 🐳 Docker Setup

### Build & Run all services

```bash
docker-compose up --build
