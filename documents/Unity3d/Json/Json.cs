public void ClickStartServer()
{
    int SessionID = int.Parse(InputFieldNumberSession.text);
    this.GET(string.Format("http://localhost/toasangbatngo/apis/get_player/{0}", SessionID), FuncDataRecieved, FuncErrorRequest);
}

private void FuncErrorRequest(WWW www)
{
    
}

private void FuncDataRecieved(WWW www)
{
    //Json du lieu tra ve phai duoc chua trong mot Object
    Debug.Log(www.text);
    MyData myData =  JsonConvert.DeserializeObject<MyData>(www.text);
    Debug.Log(myData.Players.Length);
}
//Code PHP 
public function get_player($sesID = 0){
	$data = $this->Mdl_players->where('ses_id',$sesID)->get_all();
	$data = (object)array("Players"=>$data);
	echo json_encode($data);
	// print_r($data);
}

//Cau truc class data
public class MyData
{

    public Player[] Players { get; set; }
}

public class Player
{
    public string pla_id { get; set; }
    public string pla_name { get; set; }
    public string pla_image { get; set; }
    public string created_at { get; set; }
    public string ses_id { get; set; }
}