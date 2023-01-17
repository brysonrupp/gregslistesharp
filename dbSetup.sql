CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    homes(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        style VARCHAR(255) NOT NULL COMMENT 'type of home',
        year INT NOT NULL,
        price DOUBLE NOT NULL,
        sqFeet INT NOT NULL,
        description TEXT,
        imgUrl VARCHAR(255),
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update'
    ) default charset utf8mb4 COMMENT '';

INSERT INTO
    homes (
        style,
        year,
        price,
        sqFeet,
        description,
        imgUrl
    )
VALUES (
        'Mansion',
        2020,
        2000000,
        15000,
        '9 bed, 6 bath',
        'https://image.cnbcfm.com/api/v1/image/106998054-1641517061268944AiroleWay-print-64.jpg?v=1641524919'
    );

INSERT INTO
    homes (
        style,
        year,
        price,
        sqFeet,
        description,
        imgUrl
    )
VALUES (
        'TownHome',
        2000,
        200000,
        7000,
        '3 bed, 2 bath',
        'https://www.houseplans.pro/assets/plans/764/stacked-triplex-2-bedroom-condo-6-bedrooms-total-color-T-429.jpg'
    );

INSERT INTO
    homes (
        style,
        year,
        price,
        sqFeet,
        description,
        imgUrl
    )
VALUES (
        'Mansion',
        2005,
        300000,
        10000,
        '5 bed, 3 bath',
        'https://www.rocketmortgage.com/resources-cmsassets/RocketMortgage.com/Article_Images/Large_Images/TypesOfHomes/types-of-homes-hero.jpg'
    );