function showMessage(type, message) {
    //  notify(message, type);
}

function showSpinner() {
    $("#spinner").fadeIn();
}

function hideSpinner() {
    $("#spinner").fadeOut();
}

function isNullOrEmpty(obj) {
    if (typeof obj == 'undefined' || obj === null || obj === '') return true;
    if (typeof obj == 'number' && isNaN(obj)) return true;
    if (obj instanceof Date && isNaN(Number(obj))) return true;
    return false;
}

if (!String.format) {
    String.format = function (format) {
        var args = Array.prototype.slice.call(arguments, 1);
        return format.replace(/{(\d+)}/g, function (match, number) {
            return typeof args[number] != 'undefined'
                    ? args[number]
                    : match
            ;
        });
    };
}
