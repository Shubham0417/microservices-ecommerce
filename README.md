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
