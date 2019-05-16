define(function (require, exports, module) {
    exports.init = function () {
        $("#btnLogin").click(function () {
            var userId = $("#UserId").val();
            var password = $("#Password").val();

            if (!userId || !password) {
                alert("用户名密码不能为空")
                return;
            }

            post("/api/gate/login", { "account": userId, "password": password },
                function (res) {
                    console.log(res);
                    if (!res) {
                        alert("意外错误，请刷新后重试");
                        return;
                    }
                    if (res.returnCode == 0) { //登录成功
                        location.href = "/html/index.html"
                    }
                    else {
                        alert(res.returnMessage || "用户名或密码错误，请检查后重试");
                    }
                },
                function (request, status, error) { console.error(error) }
            );
        });
    };
});