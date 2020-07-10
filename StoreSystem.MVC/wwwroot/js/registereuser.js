function Post() {
    var unm = $("#username").val();
    var pwd = $("#password").val();
    var email = $("#Email").val();
    var phonenum = $("#PhoneNum").val();
    console.log(unm);
    $.ajax(
        {
            url: "/api/ApiRegistered",
            type:"POST" ,
            data:
            {
                'UserName': unm,
                'PassWord': pwd,
                'Email': email,
                'PhoneNum': phonenum
            },
            dataType: 'json',
            success: function (data) {
                console.log(data);
                if ("success" == data.result) {
                    alert("注册成功");
                } else {
                    alert("非法注册");
                }
            }


        }
    );
}
