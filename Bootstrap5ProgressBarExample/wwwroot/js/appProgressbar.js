var $appProgressbar = $appProgressbar || {};
$appProgressbar = function () {

    // TODO refactor progressbar identifier
    var progressbarIdentifier;

    var progressWord = "Progress";
    var parentContainer;

    var init = function (parent, progressbarIdentifier) {
        parentContainer = parent;
        console.log(parentContainer);
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

    // Increments or decrements the progress bar
    var increment = function (identifier, newValue) {

        var currentValue = parseInt(newValue);

        if (currentValue > 100) {
            progressWord = '';
            currentValue = 0;
        }

        $(assertPoundSymbol(identifier))
            .css('width', currentValue + '%')
            .attr('aria-valuenow', currentValue)
            .text(currentValue + '% ' + progressWord);
        
        return currentValue;

    };

    var currentValue = function (identifier) {
        return parseInt($(identifier).attr('aria-valuenow'));
    };

    /*
     * Hide progressbar, set to 0, show progressbar
     */
    var reset = function(identifier) {

        toggle(document.querySelectorAll('.progress'));
        increment(identifier, 0);
        toggle(document.querySelectorAll('.progress'));
    };

    /*
     * Toggle element visibility
     */
    function toggle(elements, specifiedDisplay) {
        var element, index;

        elements = elements.length ? elements : [elements];

        for (index = 0; index < elements.length; index++) {
            element = elements[index];

            if (isElementHidden(element)) {
                element.style.display = '';

                // If the element is still hidden after removing the inline display
                if (isElementHidden(element)) {
                    element.style.display = specifiedDisplay || 'block';
                }
            } else {
                element.style.display = 'none';
            }
        }

        function isElementHidden(element) {
            return window.getComputedStyle(element, null).getPropertyValue('display') === 'none';
        }

    }
    //
    // Show progressbar by id e.g.
    //    $appProgressbar.Show('#progressStatus')
    //
    var show = function (identifier) {
        $(assertPoundSymbol(identifier)).show();
    };

    //
    // Hide progressbar by id e.g.
    //    $appProgressbar.Hide('#progressStatus')
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

