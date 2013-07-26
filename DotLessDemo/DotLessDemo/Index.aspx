<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DotLessDemo.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index.aspx</title>
    <%--<link href="Less/style.less" rel="stylesheet" type="text/css" />--%>
    <%--<link href="Less/base.less.css" rel="stylesheet/less" type="text/css" />--%>
    <link href="Less/style.less.css" rel="stylesheet/less" type="text/css" />
   <%-- <script src="Scripts/less-1.3.0.js" type="text/javascript"></script>--%>
    <script src="Scripts/less-1.4.1.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Index.aspx我是中国人</h2>
    </div>

    <div id="header">这里是头部</div>

     <div class="strong">这里是strong</div>

    
    </form>
</body>
</html>
