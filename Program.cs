dialog greeting = new dialog(); // Calling and instance of a method from a different class
greeting.dialogWelcomeText();

MapManager mapSpawn = new MapManager();
mapSpawn.map1Generator();

greeting.dialogPlayerName();

MainGameLoop gameStart = new MainGameLoop();
gameStart.gameLoop(mapSpawn);
