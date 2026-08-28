-- seeding data
-- Users

INSERT INTO "users" ("username", "password_hash", "role")
VALUES
    ('admin', 'dummy_hash_admin', 1),
    ('moderator', 'dummy_hash_mod', 2),
    ('gamer', 'dummy_hash_gamer', 2);


-- Game servers

INSERT INTO "game_servers"
    ("game_name", "server_size", "started_at", "status", "created_by")
VALUES
    ('Minecraft', 20, NOW() - INTERVAL '3 hours', 1, 1),
    ('Terraria', 8, NOW() - INTERVAL '47 minutes', 1, 2),
    ('Yakuza Kiwami', 4, NOW() - INTERVAL '12 minutes', 1, 1),
    ('Nightreign', 3, NOW() - INTERVAL '2 hours', 1, 3);


-- Server logs

INSERT INTO "server_logs" ("server_id", "content", "created_at")
VALUES
    (1, 'Minecraft server started successfully.', NOW() - INTERVAL '3 hours'),
    (1, 'A player tried to build a house entirely out of dirt. Administration is monitoring the situation.', NOW() - INTERVAL '2 hours'),

    (2, 'Terraria server started successfully.', NOW() - INTERVAL '47 minutes'),
    (2, 'Someone immediately summoned something they probably should not have summoned.', NOW() - INTERVAL '30 minutes'),

    (3, 'Yakuza Kiwami server started successfully.', NOW() - INTERVAL '12 minutes'),
    (3, 'WHY IS THERE A YAKUZA SERVER RUNNING.', NOW() - INTERVAL '11 minutes'),
    (3, 'Nobody knows who approved this. The server will remain online pending investigation.', NOW() - INTERVAL '10 minutes'),

    (4, 'Nightreign server started successfully.', NOW() - INTERVAL '2 hours'),
    (4, 'Party wiped. Again.', NOW() - INTERVAL '1 hour'),
    (4, 'Party wiped again. This is becoming statistically concerning.', NOW() - INTERVAL '20 minutes');