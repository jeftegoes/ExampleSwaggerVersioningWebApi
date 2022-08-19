# Example client/server soap <!-- omit in toc -->

## Contents <!-- omit in toc -->

- [1. What is this project](#1-what-is-this-project)
- [2. How is it organized](#2-how-is-it-organized)
  - [2.1. Result ApiVersioning](#21-result-apiversioning)
  - [2.2. Result ApiVersioningWithSwagger](#22-result-apiversioningwithswagger)

# 1. What is this project

- This is a project that shows how to versioning apis.

# 2. How is it organized

- ApiVersioning (.NET 6.0 / REST Client / Without swagget)
- ApiVersioningWithSwagger (.NET 6.0 / REST Client / With swagger)

## 2.1. Result ApiVersioning

|                                   |                                                                                      |
| --------------------------------- | ------------------------------------------------------------------------------------ |
| Query String Parameter Versioning | ![QueryStringApiVersionReader](Images/ApiVersioning/QueryStringApiVersionReader.PNG) |
| Media/Header API Versioning       | ![HeaderApiVersionReader](Images/ApiVersioning/HeaderApiVersionReader.PNG)           |
| Media/Header API Versioning       | ![MediaTypeApiVersionReader](Images/ApiVersioning/MediaTypeApiVersionReader.PNG)     |
| URI Versioning                    | ![URIVersioning](Images/ApiVersioning/URIVersioning.PNG)                             |
| Project                           | [ApiVersioning](ApiVersioning/)                                                      |

## 2.2. Result ApiVersioningWithSwagger

|         |                                                       |
| ------- | ----------------------------------------------------- |
| v1      | ![v1](Images/ApiVersioningWithSwagger/v1.PNG)         |
| v2      | ![v2](Images/ApiVersioningWithSwagger/v2.PNG)         |
| Project | [ApiVersioningWithSwagger](ApiVersioningWithSwagger/) |
