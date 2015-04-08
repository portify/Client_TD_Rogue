if (!isObject(TDRoguePlayGui)) {
    new GameTSCtrl(TDRoguePlayGui) {
        profile = "GuiContentProfile";
        extent = "1280 720";

        new GuiBitmapCtrl(TDR_Target) {
            extent = "16 16";
            bitmap = "./assets/target.png";
        };
    };
}

function TDRoguePlayGui::onWake(%this) {
    Canvas.pushDialog(NewChatHud);
    TDR_MoveMap.push();
}

function TDRoguePlayGui::onSleep(%this) {
    Canvas.popDialog(NewChatHud);
    TDR_MoveMap.pop();
}

package TDR_Client_PlayGui {
    function Canvas::setContent(%this, %control) {
        if (ServerConnection.isTDRogue && isObject(%control) &&
            %control.getID() == PlayGui.getID()) {
            %control = TDRoguePlayGui;
        }

        Parent::setContent(%this, %control);
    }
};

activatePackage("TDR_Client_PlayGui");
