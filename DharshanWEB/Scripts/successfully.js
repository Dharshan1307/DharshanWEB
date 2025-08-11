<script src="https://code.jquery.com/jquery-3.6.0.min.js">
    $(document).ready(function () {
        $('#contect_form').on('submit', function (e) {
            e.preventDefault(); // Prevent default form submission

            // Simulate form submission via AJAX
            $.ajax({
                url: $(this).attr('action'),
                method: $(this).attr('method'),
                data: $(this).serialize(),
                success: function (response) {
                    // Show success message
                    $('#successMessage').fadeIn().delay(3000).fadeOut();

                    // Optionally, reset form
                    $('#contect_form')[0].reset();
                },
                error: function () {
                    alert("Something went wrong.");
                }
            });
        });
    });
</script>
