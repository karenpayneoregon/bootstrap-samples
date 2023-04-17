document.addEventListener("DOMContentLoaded",
    () => {

        $('#select-tops-options').multiselect({
            buttonClass: 'form-select',
            nonSelectedText: 'Select toppings',
            buttonContainer: '<div class="btn-danger" id="select-tops-options-container"></div>',
            selectedClass: 'active multiselect-selected',
            numberDisplayed: 5,
            //buttonWidth: '36.78em',
            includeSelectAllOption: true,
            onSelectAll: function (options) {
                document.getElementById("areAllSelected").value = true;
            },
            onDeselectAll: function (options) {
                document.getElementById("areAllSelected").value = false;
            },
            onChange: function (option, checked, select) {

                $(option[0])[0].ariaChecked = checked;

                var toppings = $('#select-tops-options option:selected');

                var selected = [];

                $(toppings).each(function (index, item) {
                    selected.push([$(this).val()]);
                    console.log([$(this).val()]);
                });

                document.getElementById("PizzaToppingsValue").value = selected.join(',');
            },
            templates: {
                button:
                    '<button type="button" class="multiselect dropdown-toggle border border-success  border-3" ' +
                    'data-bs-toggle="dropdown"><span class="multiselect-selected-text"></span></button>',
                resetButton: '<div class="multiselect-reset text-center p-2"><button type="button" class="btn btn-sm btn-danger"></button></div>'
            }
        });

    });

