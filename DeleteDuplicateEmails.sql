#MySQL
DELETE
FROM Person
WHERE Id NOT in
    (
        SELECT person.id
        FROM
        (
            SELECT MIN(Id) AS id
            FROM Person
            GROUP BY Email
        ) AS person
    )