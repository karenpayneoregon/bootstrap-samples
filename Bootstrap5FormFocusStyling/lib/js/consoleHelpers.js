var $consoleHelpers = $consoleHelpers || {};
$consoleHelpers = function () {

    /*
     * %c: Applies CSS style rules to the output string as specified by the second parameter
     * %s: Text to display e.g. console.log('%c%s', styles, message);
     */

    const redGradientStyle = [
        'background: linear-gradient(#D33106, #571402)'
        , 'border: 1px solid #3E0E02'
        , 'color: white'
        , 'display: block'
        , 'text-shadow: 0 1px 0 rgba(0, 0, 0, 0.3)'
        , 'box-shadow: 0 1px 0 rgba(255, 255, 255, 0.4) inset, 0 5px 3px -5px rgba(0, 0, 0, 0.5), 0 -13px 5px -10px rgba(255, 255, 255, 0.4) inset'
        , 'line-height: 40px'
        , 'text-align: center'
        , 'font-size: 30px'
        , 'font-weight: bold'
    ].join(';');

    const warningTitleStyle = [
        'background: red'
        , 'color: white'
        , 'display: block'
        , 'text-shadow: 0 1px 0 rgba(0, 0, 0, 0.3)'
        , 'box-shadow: 0 1px 0 rgba(255, 255, 255, 0.4) inset, 0 5px 3px -5px rgba(0, 0, 0, 0.5), 0 -13px 5px -10px rgba(255, 255, 255, 0.4) inset'
        , 'line-height: 14px'
        , 'text-align: center'
        , 'font-size: 12px'
        , 'font-weight: bold'
    ].join(';');

    const successStyle = [
        'background: green'
        , 'border: 1px solid #3E0E02'
        , 'color: white'
        , 'display: block'
        , 'text-shadow: 0 1px 0 rgba(0, 0, 0, 0.3)'
        , 'box-shadow: 0 1px 0 rgba(255, 255, 255, 0.4) inset, 0 5px 3px -5px rgba(0, 0, 0, 0.5), 0 -13px 5px -10px rgba(255, 255, 255, 0.4) inset'
        , 'line-height: 14px'
        , 'text-align: center'
        , 'font-size: 12px'
        , 'font-weight: bold'
    ].join(';');

    var redGradient = function(message) {
        console.log(`%c${message}`, redGradientStyle);
    };

    var success = function (message) {
        console.log(`%c%s`, successStyle, message);
    };

    var warning = function(title, message) {
        console.log(`%c${title}%c %c${message}`,
            warningTitleStyle,
            'color: white',
            'color: black'
        );
    };

    return {
        redGradient: redGradient,
        success: success,
        warning: warning
    };
}();