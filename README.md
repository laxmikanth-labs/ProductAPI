This ASP.NET Core Web API project integrates JWT-based authentication, Swagger UI authorization, and CORS configuration to support secure, modern API development. It enables token-based access control, seamless API testing through Swagger, and cross-origin communication

Features Added

🔧 Feature	📋 Description
JWT Authentication	Secures API endpoints using JSON Web Tokens. Only users with valid tokens can access protected routes.
Authorization Middleware	Enables the [Authorize] attribute to restrict endpoint access.
Swagger JWT Integration	Adds a Bearer token input field in Swagger UI so developers can test secured endpoints.
Token Validation	Ensures token is valid, not expired, and issued by a trusted source.
CORS Policy	Allows requests from http://localhost:4200, enabling Angular or other frontend apps to consume the API.

This setup is ideal for building secure APIs with a smooth developer experience during development and testing.

