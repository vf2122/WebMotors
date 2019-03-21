<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebMotors.Apresentation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div id="app">
        {{ message }}
    </div>



    <script src="https://cdn.jsdelivr.net/npm/vue"></script>
    <script src="https://unpkg.com/axios/dist/axios.min.js"></script>
    
    <script type="text/javascript">

        var app = new Vue({
            el: '#app',
            data: {
                message: 'Hello Vue!'
            },
            mounted: function () {
                axios.get('http://localhost:54468/Default.aspx')
            }
        })
    </script>

</body>
</html>
