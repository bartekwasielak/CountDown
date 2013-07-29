// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;
    var notifications = Windows.UI.Notifications;
    notifications.TileUpdateManager.createTileUpdaterForApplication().enableNotificationQueue(true);
    var template = notifications.TileTemplateType.tileWideBlockAndText01;
    var squareTemplate = notifications.TileTemplateType.tileSquareText01;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize
                // your application here.
            } else {
                // TODO: This application has been reactivated from suspension.
                // Restore application state here.
            }
            args.setPromise(WinJS.UI.processAll().then(function completed() {
                WinJS.Binding.processAll(document.rootElement, Events.model);
            }));
        }
    };

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };

    setInterval(function() {
        Events.model.events.forEach(function (event) {
            event._calculate();
        });
    }, 250);

    function updateTiles() {
        var i = 0;
        Events.model.events.forEach(function(event) {
            if (++i > 5)
                return;

            var tileXml = notifications.TileUpdateManager.getTemplateContent(template);
            var squareTileXml = notifications.TileUpdateManager.getTemplateContent(squareTemplate);

            var tileTextAttributes = tileXml.getElementsByTagName("text");
            tileTextAttributes[0].appendChild(tileXml.createTextNode(event.name));
            tileTextAttributes[3].appendChild(tileXml.createTextNode(event.secondarySpan));
            tileTextAttributes[4].appendChild(tileXml.createTextNode(event.mainSpanValue));
            tileTextAttributes[5].appendChild(tileXml.createTextNode(event.mainSpanUnit));

            var squareTileTextAttributes = squareTileXml.getElementsByTagName("text");
            squareTileTextAttributes[0].appendChild(squareTileXml.createTextNode(event.mainSpanValue));
            squareTileTextAttributes[1].appendChild(squareTileXml.createTextNode(event.mainSpanUnit));
            squareTileTextAttributes[2].appendChild(squareTileXml.createTextNode(event.name));

            var node = tileXml.importNode(squareTileXml.getElementsByTagName("binding").item(0), true);
            tileXml.getElementsByTagName("visual").item(0).appendChild(node);
            var tileNotification = new notifications.TileNotification(tileXml);
            var currentTime = new Date();
            tileNotification.expirationTime = new Date(currentTime.getTime() + 30 * 1000);
            tileNotification.tag = "event" + i;
            notifications.TileUpdateManager.createTileUpdaterForApplication().update(tileNotification);
        });
    }

    setTimeout(function() {
        updateTiles();
        setInterval(function() {
            updateTiles();
        }, 20000);
    }, 500);
    

    app.start();
})();
