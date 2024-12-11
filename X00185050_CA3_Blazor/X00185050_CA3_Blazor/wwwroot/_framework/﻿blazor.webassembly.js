(function () {
    "use strict";

    var blazor = {
        _internal: {
            platforms: {
                wasm: "wasm"
            }
        }
    };

    // Import the .NET runtime
    var dotnetRuntime = {
        module: null,
        initialize: function (options) {
            var self = this;
            this.module = options.module;
            this.loadedCallback();
        },
        loadedCallback: function () {
            if (this.module && this.module._blazorStart) {
                this.module._blazorStart();
            }
        }
    };

    // Set the platform to "wasm"
    window.Blazor = blazor;
    window._dotnetRuntime = dotnetRuntime;
})();
