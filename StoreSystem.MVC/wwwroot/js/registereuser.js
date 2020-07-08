$("#registered").click(function () {
    var unm = $("#username").val();
    var pwd = $("#password").val();
    var nickname = $("#nickname").val();
    var phonenum = $("#phonenum").val();
    $.ajax(
        {
            url: "/api/user/registereduser",
            type: "post",
            data:
            {
                'UserName': unm,
                'PassWord': pwd,
                'NickName': nickname,
                'PhoneNum':phonenum
            },
            dataType: 'json',
            success: function (data) {
                if ("success" == data.result) {
                     alart("注册成功");
                }
                else {
                    alart("非法注册");
                }
            }


        }
    );
});
