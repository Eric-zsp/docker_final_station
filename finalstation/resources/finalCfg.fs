/* 该配置采用HJSON格式 */
{
#serverIP 不需要修改
serverIP:0.0.0.0
#TCP server 模式监听端口
tcpPort:12306
#UDPP server 模式监听端口
udpPort:12307
#服务器API接口地址，接口根路径
apiUrl:http://192.168.100.111:30003/api/iotdata/FinalStationApi/
#终端数据存储目录
dataDir:/finalstation/data/
#虚拟点计算任务运行周期(已废弃)
dataVirtuaNodeJobCorn:0/2 * * * * ? *
#配置文件升级检测周期,每两秒执行一次
configUpdateJobCorn:0/2 * * * * ? *
#拉取反向控制指令周期,每两秒执行一次
controlPullJobCorn:0/2 * * * * ? *
#采样报警超时检测周期每30秒执行一次
alarmInquiryTimeOutJobCorn:0/30 * * * * ? *
#历史信息上传周期（当前信息队列失败会保存到历史文件中）,//每三十秒执行一次
historyDataUploadJobCorn:0/30 * * * * ? *
#历史信息每次取出条数
historyOnceGetFromData:3000
#运算型任务运行周期（极值、报警等）每两秒执行一次
dataCalculationJobCorn:0/2 * * * * ? *
#本地历史日志及数据清理周期每天零点零分执行一次
logAndDataClearJobCorn:0 0 0 * * ? *
#数据库中保留分钟级数据的分钟数，默认60
dbMinuteCount:4320
#数据库中保留小时级数据的小时数，默认24
dbHourCount:72
#数据库中保留天级数据的天数，默认30
dbDayCount:30
# 数据库中保留月数据的月数，默认12
dbMonthCount:12
#数据库中保留年级数据的年数，默认3
dbYearCount:5
#job 执行耗时记录
jobTimeFeed:false
#是否上传数据 （测试模式下需要终端产生的数据可以只采集不上传）
uploadDataToServer:true
#数据上传时是否启用压缩
compressDataUpload:true
roomKeyModelList:[
        {
            p_companyCD:TEST001
            p_projectCD:TEST0010000001
            p_roomCD:TEST00100000010000001
            #服务器接口key，每个roomCD一个key
            p_key:123a
        }
    ]
}