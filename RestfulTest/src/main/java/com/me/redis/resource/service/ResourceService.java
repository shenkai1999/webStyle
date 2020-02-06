package com.me.redis.resource.service;
import com.me.redis.resource.bean.ChangeToPinyin;
import net.sourceforge.pinyin4j.format.exception.BadHanyuPinyinOutputFormatCombination;
import org.springframework.stereotype.Service;

@Service
public class ResourceService {
 ChangeToPinyin temp = new ChangeToPinyin();

 public String test(String hanzi) throws BadHanyuPinyinOutputFormatCombination {
     return temp.toPinYin(hanzi);
 }

}
