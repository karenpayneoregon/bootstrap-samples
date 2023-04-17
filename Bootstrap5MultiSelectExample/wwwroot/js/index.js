document.addEventListener("DOMContentLoaded",
    () => {


        $('#select-tops-options').multiselect({
            buttonClass: 'form-select',
            nonSelectedText: 'Select toppings',
            buttonContainer: '<div class="btn-danger" id="select-tops-options-container"></div>',
            selectedClass: 'active multiselect-selected',
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
            onChange: function (option, checked) {
                /*
                 * Not there yet
                 */
                if (checked) {
                    document.querySelectorAll(`[value="${$(option[0])[0].value}"]`)[1].ariaChecked = "true";
                    document.querySelectorAll(`[value="${$(option[0])[0].value}"]`)[0].ariaChecked = "true";
                } else {
                    document.querySelectorAll(`[value="${$(option[0])[0].value}"]`)[1].ariaChecked = "false";
                    document.querySelectorAll(`[value="${$(option[0])[0].value}"]`)[0].ariaChecked = "false";
                }
                
                //$("#select-tops-options").multiselect('deselect', '1');
                var toppings = $('#select-tops-options option:selected');

                var selected = [];
                $(toppings).each(function (index, item) {
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
