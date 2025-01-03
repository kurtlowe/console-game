Dialog Greeting = new Dialog(); // Calling and instance of a method from a different class
Greeting.DialogWelcomeText();

MapManager MapSpawn = new MapManager();
MapSpawn.Map1Generator();

Dialog PlayerWelcome = new Dialog();
PlayerWelcome.DialogPlayerName();

/*Map1 Generate = new Map1();
    Generate.Map1Generation();*/

MainGameLoop GameStart = new MainGameLoop();
GameStart.GameLoop();
