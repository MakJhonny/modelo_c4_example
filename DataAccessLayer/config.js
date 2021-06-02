module.exports = {
    "development": {
      "username": "Access", // ← Usuario de la DB
      "password": "Access", // ← Contraseña del usuario de la DB
      "database": "Access", // ← Nombre de la DB previamente creada
      "host": "127.0.0.1",
      "dialect": "Access"
    },
    "test": {
      "username": "root",
      "password": null,
      "database": "database_test",
      "host": "127.0.0.1",
      "dialect": "Access"
    },
    "production": {
      "username": "root",
      "password": null,
      "database": "database_production",
      "host": "127.0.0.1",
      "dialect": "Access",
      "NODE_ENV": "production",
      "define": {
        "schema": "public",
        "timestamps": false
      },
      "dialectOptions": {
        "ssl": {
          "rejectUnauthorized": false,
          "require":true
        }
      },
      "use_env_variable": "DATABASE_URL"
    }
  }