/**
     * Get data from
     * @param id
     * @param url
     * @param objData
     * @example this.loadOneData('customer/' + $this.$stateParams.id);
     */
    loadOneData(url){
        let $this = this;
        $this.API.all(url).customGET()
            .then((response) =>{
                $this.data = response.data.customer;
            });
    }