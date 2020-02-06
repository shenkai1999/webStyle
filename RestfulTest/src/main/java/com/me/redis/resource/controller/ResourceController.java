package com.me.redis.resource.controller;

import net.sourceforge.pinyin4j.format.exception.BadHanyuPinyinOutputFormatCombination;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import com.me.redis.resource.service.ResourceService;

@RestController
public class ResourceController {

    @Autowired
    ResourceService resourceService;
    @RequestMapping(value = "/changetopinyin", method = RequestMethod.PUT)
    @ResponseBody
    public  String getCount(@RequestParam(value = "hanzi") String hanzi) throws BadHanyuPinyinOutputFormatCombination {
        System.out.println(resourceService.test(hanzi));
        return  resourceService.test(hanzi);
    }

}
