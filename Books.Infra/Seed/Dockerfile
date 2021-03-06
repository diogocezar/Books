FROM mongo

COPY init.json /init.json
CMD mongoimport --host mongodb --db Books --collection BookstoreDb --type json --file /init.json --jsonArray