<script>
    $(document).ready(function () {
        $('#contect_form').submit(function (e) {
            e.preventDefault(); 

            $.ajax({
                type: 'POST',
                url: 'AddCusValuesPost', 
                data: $(this).serialize(), 
                success: function (response) {
                    alert("Form submitted successfully! 🎉");
                    $('#contect_form')[0].reset(); 
                },
                error: function () {
                    alert("Something went wrong. Please try again.");
                }
            });
        });
    });
</script>
