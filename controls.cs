if (!isObject(TDR_MoveMap)) {
    new ActionMap(TDR_MoveMap);

    TDR_MoveMap.bindCmd("keyboard", "escape", "", "escapeMenu.toggle();");
    TDR_MoveMap.bind("keyboard", "w", moveforward);
    TDR_MoveMap.bind("keyboard", "s", movebackward);
    TDR_MoveMap.bind("keyboard", "a", moveleft);
    TDR_MoveMap.bind("keyboard", "d", moveright);
    TDR_MoveMap.bind("keyboard", "lshift", walk);
    TDR_MoveMap.bind("keyboard", "f8", dropCameraAtPlayer);
    TDR_MoveMap.bind("keyboard", "f7", dropPlayerAtCamera);
    TDR_MoveMap.bind("keyboard", "t", globalChat);
    TDR_MoveMap.bind("keyboard", "pageup", pageUpNewChatHud);
    TDR_MoveMap.bind("keyboard", "pagedown", pageDownNewChatHud);
    TDR_MoveMap.bind("keyboard", "m", toggleCursor);
    TDR_MoveMap.bind("keyboard", "ctrl a", openAdminWindow);
    TDR_MoveMap.bind("keyboard", "ctrl o", openOptionsWindow);
    TDR_MoveMap.bind("keyboard", "ctrl p", doScreenShot);
    TDR_MoveMap.bind("keyboard", "shift p", doHudScreenshot);
    TDR_MoveMap.bind("keyboard", "shift-ctrl p", doDofScreenShot);
    TDR_MoveMap.bind("keyboard", "ctrl k", suicide);
    TDR_MoveMap.bind("keyboard", "f2", showPlayerList);
    TDR_MoveMap.bind("keyboard", "ctrl n", toggleNetGraph);
    TDR_MoveMap.bind(mouse0, "xaxis", tdr_xaxis);
    TDR_MoveMap.bind(mouse0, "yaxis", tdr_yaxis);
    TDR_MoveMap.bind(mouse0, "button0", mouseFire);
    TDR_MoveMap.bind(mouse0, "button1", jet);
    // TDR_MoveMap.bind(mouse0, "zaxis", scrollInventory);
}

function tdr_xaxis(%amount) {
    %x = getWord(TDR_Target.position, 0) + 8;
    %y = getWord(TDR_Target.position, 1) + 8;

    %x = mClampF(%x + %amount, 0, getWord(TDRoguePlayGui.extent, 0));
    %y = mClampF(%y          , 0, getWord(TDRoguePlayGui.extent, 1));

    TDR_Target.position = %x - 8 SPC %y - 8;
}

function tdr_yaxis(%amount) {
    %x = getWord(TDR_Target.position, 0) + 8;
    %y = getWord(TDR_Target.position, 1) + 8;

    %x = mClampF(%x          , 0, getWord(TDRoguePlayGui.extent, 0));
    %y = mClampF(%y + %amount, 0, getWord(TDRoguePlayGui.extent, 1));

    TDR_Target.position = %x - 8 SPC %y - 8;
}
