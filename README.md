# .NetCore Onion Architecture

## Introduction: What is Onion Architecture?

Most of the traditional architectures raise fundamental issues of tight coupling and separation of concerns. Onion Architecture was introduced by Jeffrey Palermo to provide a better way to build applications in perspective of better testability, maintainability, and dependability. Onion Architecture addresses the challenges faced with 3-tier and n-tier architectures, and to provide a solution for common problems. Onion architecture layers interact to each other by using the Interfaces.

## Principles

Onion Architecture is based on the inversion of control principle. Onion Architecture is comprised of multiple concentric layers interfacing each other towards the core that represents the domain. The architecture does not depend on the data layer as in classic multi-tier architectures, but on the actual domain models.

## Problem and Solution

As per traditional architecture, the UI layer interacts to business logic, and business logic talks to the data layer, and all the layers are mixed up and depend heavily on each other. In 3-tier and n-tier architectures, none of the layers are independent; this fact raises a separation of concerns. Such systems are very hard to understand and maintain. The drawback of this traditional architecture is unnecessary coupling.

## Project Diagram

![project-diagram](https://www.linkpicture.com/q/project-diagram.png "Logo Title Text 1")

## Onion Architecture Diagram

![project-diagram](https://serving.photos.photobox.com/571668572a803650fe05adb289f4dc614a408e0d7e9e99c76c6488c32b8bdd566a16c0a9.jpg "Logo Title Text 1")

## Project Architecture

+ Onion.Domain
+ Onion.Repository
+ Onion.Service
+ Onion.IoC (Inversion Of Control)

# Onion.Repository Package Manager

> Install-Package Microsoft.EntityFrameworkCore.SqlServer
> Install-Package Microsoft.EntityFrameworkCore.Tools
> Install-Package Microsoft.EntityFrameworkCore.Design

# Onion.IoC Package Manager

> Install-Package Microsoft.Extensions.DependencyInjection