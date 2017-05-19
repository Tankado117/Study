using System;
using System.Web.Mvc;

//Modelをusingしないと、モデルで宣言してる変数が使用できない！！
using HelloMCV.Models;

namespace HelloMCV.Controllers
{
    public class HomeController : Controller
    {
        //下のIndexの部分がページの名前になっている。Index.cshtmlの中でやる処理を書いている
        public ActionResult Index()
        {
            ViewData["Post1"] = "数字を入力してください。";
            return View();
        }

        //下のAnserの部分がページの名前になっている。Anser.cshtmlの中でやる処理を書いている
        public ActionResult Anser(string textBox)
        {
            //これでインスタンスを作成してやっと候補にModelの変数が出てくる
            HomeModel Model = new HomeModel();
            Model.number = int.Parse(textBox);
            Model.count = Model.number;

            //1からユーザが入力した数字まで表示させる処理
            for (Model.number = 1; Model.number <= Model.count; Model.number++)
            {
                Model.before += Model.number.ToString();
                Model.before += ",";
            }

            //FizzBuzzの処理
            for (Model.number = 1; Model.number <= Model.count; Model.number++)
            {
                //15で割り切れたらFizzBuzzと表示する
                if (Model.number % 15 == 0)
                {
                    Model.after += "FizzBuzz";
                }
                //3で割り切れたらFizzと表示する
                else if (Model.number % 3 == 0)
                {
                    Model.after += "Fizz";
                }
                //5で割り切れたらBuzzと表示する
                else if (Model.number % 5 == 0)
                {
                    Model.after += "Buzz";
                }
                //それ以外は数字を表示する
                else
                {
                    Model.after += Model.number.ToString();
                }
                Model.after += ",";
            }

            //列の最後の","を消す
            Model.before = Model.before.TrimEnd(',');
            Model.after = Model.after.TrimEnd(',');

            //結果をviewに渡す
            ViewData["PostData"] = textBox + "のFizzBuzzを表示します。";
            ViewData["Before"] = Model.before;
            ViewData["After"] = Model.after;

            return View();
        }

    }
}