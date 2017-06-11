Tip cập nhật add them query han che vao MY_Model
1/ protected $_database; to public $_database; trong file MY_Model.php
2/ Use
$this->Mdl_warehouse_v2->_database->where_in('ware_id',$temp);// Su dung function cua codeigniter
$data = $this->Mdl_warehouse_v2->where('ware_status','disable')->get_all();
echo $this->Mdl_warehouse_v2->_database->last_query();