(function () {  
    var Event = WinJS.Class.define(
        function (name, date, color) {
            this._initObservable();
            this.name = name;
            this.date = date;
            this.mainSpanValue = "";
            this.secondarySpan = "";
            this.mainSpanUnit = "";
            this.inPast = false;
            this.color = color;
        },
        {
            _calculate: function() {
                var date = Date.parse(this.date);
                var diff = date - new Date();
                if (diff < 0)
                    this.inFuture = true;
                diff = Math.abs(diff);
                var days = Math.floor(diff / Event._d);
                var hours = Math.floor((diff - (days * Event._d)) / Event._h);
                var minutes = Math.floor((diff - (days * Event._d + hours * Event._h)) / Event._m);
                var seconds = Math.floor((diff - (days * Event._d + hours * Event._h + minutes * Event._m)) / Event._s);
                if (days != 0) {
                    this.setProperty("mainSpanValue", days);
                    this.setProperty("mainSpanUnit", "days");
                    this.setProperty("secondarySpan", hours + " hours " + minutes + " minutes");
                    return;
                }
                if (hours != 0) {
                    this.setProperty("mainSpanValue", hours);
                    this.setProperty("mainSpanUnit", "hours");
                    this.setProperty("secondarySpan", minutes + " minutes");
                    return;
                }
                this.setProperty("mainSpanValue", minutes);
                this.setProperty("mainSpanUnit", "minutes");
                this.setProperty("secondarySpan", "");
            }
        },
        {
            _d: 86400000,
            _h: 3600000,
            _m: 60000,
            _s: 1000
        }
        );
    
    WinJS.Class.mix(Event,
        WinJS.Binding.mixin,
        WinJS.Binding.expandProperties({ name: "", mainSpanUnit: "", mainSpanValue: "", secondarySpan: "", inPast: false, color: "" })
    );
    
    WinJS.Namespace.define("Events", {
        Event: Event,

        model: WinJS.Binding.as({
            date: new Date(),
            events: new WinJS.Binding.List([
                new Event("Koniec projektu", "2013-08-09T17:00", "#008299"),
                new Event("Przylot Izy", "2013-08-11T06:25", "#D24726"),
                new Event("Powrót", "2013-08-18T11:25", "#008A00"),
                new Event("Pobyt w Tokio", "2013-06-02T15:20", "#AC193D")
            ])
        })
    });
})();