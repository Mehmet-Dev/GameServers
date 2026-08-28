-- create databases penis balls
CREATE TABLE "users"(
    "id" BIGINT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    "username" TEXT NOT NULL UNIQUE,
    "password_hash" TEXT NOT NULL,
    "role" SMALLINT NOT NULL
);

CREATE TABLE "game_servers"(
    "id" BIGINT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    "game_name" TEXT NOT NULL,
    "server_size" SMALLINT NOT NULL,
    "started_at" TIMESTAMPTZ NOT NULL,
        "status" SMALLINT NOT NULL,
    "created_by" BIGINT NOT NULL REFERENCES "users"("id")
);

CREATE TABLE "server_logs"(
    "id" BIGINT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    "server_id" BIGINT NOT NULL REFERENCES "game_servers"("id"),
    "content" TEXT NOT NULL,
    "created_at" TIMESTAMPTZ NOT NULL
)