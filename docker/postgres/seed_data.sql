-- Seeding data

-- Users

INSERT INTO "users"
    ("username", "password_hash", "role", "created_at", "updated_at")
VALUES
    ('moderator', 'dummy_hash_mod', 0, NOW() - INTERVAL '7 days', NOW() - INTERVAL '2 hours'),
    ('admin', 'dummy_hash_admin', 1, NOW() - INTERVAL '5 days', NOW() - INTERVAL '1 day'),
    ('superduperultraadmin', 'dummy_hash_superadmin', 2, NOW() - INTERVAL '2 days', NOW() - INTERVAL '3 hours');


-- Game servers

INSERT INTO "game_servers"
    ("game_name", "server_size", "started_at", "status", "created_by", "created_at", "updated_at")
VALUES
    ('Minecraft', 20, NOW() - INTERVAL '3 hours', 1, 1, NOW() - INTERVAL '3 hours', NOW() - INTERVAL '3 hours'),
    ('Terraria', 8, NOW() - INTERVAL '47 minutes', 1, 2, NOW() - INTERVAL '47 minutes', NOW() - INTERVAL '20 minutes'),
    ('Yakuza Kiwami', 4, NOW() - INTERVAL '12 minutes', 1, 1, NOW() - INTERVAL '12 minutes', NOW() - INTERVAL '10 minutes'),
    ('Nightreign', 3, NOW() - INTERVAL '2 hours', 1, 3, NOW() - INTERVAL '2 hours', NOW() - INTERVAL '20 minutes');


-- Server logs

INSERT INTO "server_logs"
    ("server_id", "content", "created_at")
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