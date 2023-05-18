var $ClaimsProgressbar = $ClaimsProgressbar || {};
$ClaimsProgressbar = function () {
    var progressWord = "Progress";

    var init = function (option) {
        
    };

    //
    // Append # to incoming value to ensure it's an
    // identifier
    //
    var assertPoundSymbol = function (value) {

        if (value.charAt(0) !== "#") {
            value = "#" + value;
        }

        return value;
    };

    // Increments or decrements the progress bar on all pages
    var increment = function (identifier, newValue) {
        var currentValue = parseInt(newValue);

        if (currentValue > 100) {
            progressWord = '';
            currentValue = 0;
        }

        $(assertPoundSymbol(identifier))
            .css("width", currentValue + "%")
            .attr("aria-valuenow", currentValue)
            .text(currentValue + "% " + progressWord);
        

        return currentValue;
    };

    var currentValue = function (identifier) {
        return parseInt($(identifier).attr("aria-valuenow"));
    };

    var reset = function(identifier) {

        console.log('dsss');
        $('#progressStatus').hide();
        $('#progressStatus').show();
    };
    //
    // Show progressbar by id e.g.
    //    $ClaimsProgressbar.Show('#progressStatus')
    //
    var show = function (identifier) {
        $(assertPoundSymbol(identifier)).show();
    };


    //
    // Hide progressbar by id e.g.
    //    $ClaimsProgressbar.Hide('#progressStatus')
    //    
    var hide = function (identifier) {
        $(assertPoundSymbol(identifier)).hide();
    };

    return {
        init: init,
        CurrentValue: currentValue,
        Increment: increment,
        Show: show,
        Hide: hide,
        reset: reset

    };
}();

