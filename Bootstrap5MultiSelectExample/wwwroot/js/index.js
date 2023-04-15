document.addEventListener("DOMContentLoaded",
    () => {

        $('#select-tops-options').multiselect({
            buttonClass: 'form-select',
            nonSelectedText: 'Select toppings',
            numberDisplayed: 5,
            buttonWidth: '18em',
            includeSelectAllOption: true,
            onSelectAll: function (options) {
                document.getElementById("areAllSelected").value = true;

            },
            onDeselectAll: function (options) {
                document.getElementById("areAllSelected").value = false;
            },
            //includeResetOption: true,
            //selectAllName: 'select-all-name',
            onChange: function (element, checked) {
                var toppings = $('#select-tops-options option:selected');
                var selected = [];
                $(toppings).each(function (index, brand) {
                    selected.push([$(this).val()]);
                });
                document.getElementById("PizzaToppingsValue").value = selected.join(',');
            },
            templates: {
                button:
                    '<button type="button" class="multiselect dropdown-toggle" ' +
                    'data-bs-toggle="dropdown"><span class="multiselect-selected-text"></span></button>',
                resetButton: '<div class="multiselect-reset text-center p-2"><button type="button" class="btn btn-sm btn-danger"></button></div>'
            }
        });

    });



$('form').submit(function (e) {
    if (document.getElementsByClassName("multiselect-selected-text")[0].innerHTML !== 'Select toppings') {
        document.getElementById("foot").innerHTML = `<strong>Selected</strong><span class='text-danger'>
                            ${document.getElementsByClassName("multiselect")[0].title}</span>`;
    } else {
        document.getElementById("foot").innerHTML = "<span class='text-danger fw-bold'>Please make your selections</span>";
    }


});
