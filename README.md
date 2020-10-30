## Setup
To get started run the following command at the project root

```
docker-compose up -d
```

This will start a web app and database on your local computer. The port the server runs on is 5001.

## Request Users
To make a request to get a member you'd use the following

`GET https://localhost:5001/api/member/contact/1`

## Modify Users
The server is currently seeded with 4 test users and to modify them you can use the following

`POST https://localhost:5001/api/member/contact/1`

*Note: you can only update existing users. You cannot add new users*

## Swagger

Docs can be viewed at

`https://localhost:5001/swagger`