$this.dtOptions = $this.DTOptionsBuilder.newOptions()
            .withOption('ajax', {
                url        :'order/datatables',//Link request
                type       :'GET', headers:{
                    Authorization:'Bearer ' + localStorage.getItem('satellizer_token')
                },
                data       :function(data){
                    if(angular.isDate($this.date.start)){
                        data.date_start = $this.$filter('date')($this.date.start, "yyyy-MM-dd 00:00:00");
                    }
                }, complete:function(jqXHR, textStatus){//call is request success
                    $this.loadProducts();
                }
            })
            // or here
            .withBootstrap()
            .withLanguage(language)//set language
            .withDataProp('data')
            .withOption('processing', true)
            .withOption('serverSide', true)
            .withOption('order', [0, 'desc'])
            .withOption('fnRowCallback', rowCallback)
            .withPaginationType('full_numbers');
        $this.dtColumns = [
            $this.DTColumnBuilder.newColumn('<TenTrongData>').withTitle('<TenHienThi>'),
            $this.DTColumnBuilder.newColumn('total').withTitle('T?ng ti?n').renderWith(function(data, type){
                return '<p class="text-center">' + $this.$filter('number')(data, '0') + '</p>';
            }),
            $this.DTColumnBuilder.newColumn('action').withTitle('Tùy ch?n').withOption('searchable', false).withOption('width', '50%')
        ];
        function rowCallback(nRow, aData, iDisplayIndex, iDisplayIndexFull){
            $this.$compile(nRow)($this.$scope);
        }