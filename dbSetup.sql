CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL PRIMARY KEY COMMENT 'primary key',
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR(255) COMMENT 'User Name',
  email VARCHAR(255) UNIQUE COMMENT 'User Email',
  picture VARCHAR(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE chores(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  description VARCHAR(255),
  is_complete BOOLEAN DEFAULT false,
  num_workers TINYINT UNSIGNED NOT NULL DEFAULT 1
);

INSERT INTO 
chores(name, description)
VALUES("Walk the raccoons", "Don't go to the dog park, we are banned for life.");

INSERT INTO chores(name, description, num_workers)
VALUES (
    "Walk the watches",
    "Stick to the schedule and you should be fine.",
    2
  ),
  (
    "Walk the plants",
    "Don't forget to put the pots on the wheel platforms. It's easier that way.",
    1
  ),
  (
    "Walk the protein bars",
    "It's more of a carry than a walk, they carry you. The more liftable objects, the better.",
    3
  ),
  (
    "Walk the philosophers",
    "Show up for a walk, discover walks of life",
    4
  ),
  (
    "Walk the developers",
    "Minimize contact with sunlight, extra sunscreen may be necessary.",
    1
  );

  DROP TABLE chores;