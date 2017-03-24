Create Table IF NOT EXISTS Chartacters(
actor_name nvarchar(80),
actor_id integer unique,
sprite nvarchar(255),
is_playable boolean,
health_points double,
mana_points double,
backstory text,
charateristics text,
Primary Key(actor_id));

Create Table IF NOT EXISTS Worlds(
world_name nvarchar(80),
world_map nvarchar(255),
world_id integer unique,
recomended_rules integer,
primary key(world_name));

Create Table IF NOT EXISTS Rulesets(
ruleset_name nvarchar(80),
ruleset_id integer unique,
rules_text text,
primary key(ruleset_id));
