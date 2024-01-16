#!/bin/sh

mysql -h localhost -u root -p123456 poc < /app/db-script.sql
